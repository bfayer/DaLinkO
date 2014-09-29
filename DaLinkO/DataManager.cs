using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DaLinkO
{
    public class DataManager
    {
        public DR bActive = new DR();

        public event ActiveBeansUpdatedHandler packsAreUpdated;
        public event NewSourceAddedHandler newSourceData;

        

        //Primary public methods
        public void updateDataPacks(DR dIncoming)
        {
            /*gets new data transmissions and based on the tramsmission version sends them
             * to the proper update method 
             */

            string tv = dIncoming.TV.ToString();

            if (tv == "1.00")
            {

                //update1_00(dIncoming);
                AddXML_1(dIncoming);
            }
        }

        public void AddXML_1(DR bNew)
        {
            //var merged = new List<DP>(bActive.dataPacks);
            //merged.AddRange(bNew.dataPacks.Where(p2 =>
            //    bActive.dataPacks.All(p1=>p1.Src != p2.Src)));
            // need to make the bActive datapack equal to merged now.
                //private DR DRforThreading
            lock (((ICollection)bActive.dataPacks).SyncRoot)
            {
                foreach (var newPack in bNew.dataPacks) //for each data pack in the new packlist
                {
                    //query all of the existing packs that match by name and version
                    if (bActive.dataPacks.Count != 0)
                    {
                        var activePackQuery =
                            from a in bActive.dataPacks
                            where a.Src == newPack.Src && a.v == newPack.v
                            select a;
                        if (activePackQuery.Count() == 0)//if none of the existing packs matched the new pack then add it
                        {

                            bActive.dataPacks.Add(newPack);
                        }
                        else //if any of the existing packs matched the new pack then try to update their elements
                        {

                            foreach (var activePack in activePackQuery) //for each existing pack that was found to match the current new pack
                            {
                                foreach (var newElement in newPack.dataElement) //For each data element on the specific new pack 
                                {
                                    //MessageBox.Show("check");
                                    //query the existing pack's dataElement list to see if there are duplicates with the new datapack's dataElement list
                                    var elementQuery =
                                        from b in activePack.dataElement
                                        where b.N == newElement.N
                                        select b;
                                    if (elementQuery.Count() == 0)//if the element didn't already exist add it to the active pack
                                    {
                                        activePack.dataElement.Add(newElement);
                                        newSourceData();
                                    }
                                    else //if the element did already exist update all of them
                                    {

                                        foreach (var matchingElement in elementQuery) //for each element that existed already update the value
                                        {
                                            matchingElement.V = newElement.V;
                                        }
                                    }

                                    activePack.LastHeardFrom = DateTime.Now; //refreshes the lastheard from variable for the updated active pack

                                }

                            }
                        }
                    }
                    else
                    {
                        bActive.dataPacks.Add(newPack); //if no packs exist just add the new one
                        newSourceData();
                    }


                }

                if (packsAreUpdated != null) // global event for data updated, will be null if no subscribers, 
                {
                    packsAreUpdated();  //global trigger for packs are updated, may be depreciated now that im doing it by passing the objects rather than events
                }
            }
        }

        public void loadSavedData(Transmission loadedTransmission)
        {
            foreach (TElement t in loadedTransmission.TElementList)
            {


                if (t.elementName != "trigger")
                {
                    //something is wrong here, I think it
                    //needs to check to see that there isn't one already, if there is one already set the target equal to that one, the way it is 
                    //right now is bugged out because if there are multiple references to the same thing it keeps overwriting the element with a new one instead of
                    //simply updating the values and changing the target of the transmission


                    /* new idea
                     * 
                     * create entirely new active bean pack from all of the T elements in a broadcast
                     * cast that to the inbound add data class
                     * re link the telement's linked element

                    */



                    DR tempDR = new DR();
                    DP tempDP = new DP();
                    DE tempDE = new DE();

                    tempDE.N = t.linkedElement.N;
                    tempDE.T = t.linkedElement.T;
                    tempDE.V = t.linkedElement.V;

                    tempDP.LastHeardFrom = DateTime.Now;
                    tempDP.Src = t.elementSourceName;
                    tempDP.v = t.modversion;


                    tempDP.dataElement.Add(tempDE);
                    tempDR.dataPacks.Add(tempDP);
                    tempDR.TV = "1.00";
                    AddXML_1(tempDR); 

                    reattachLinkeElement(t);


                }
            }

            //this probably shouldn't be used because this is all ghost data anyways from previous saves
            //if (packsAreUpdated != null) // will be null if no subscribers
            //{
            //    packsAreUpdated();  //global trigger for packs are updated, may be depreciated now that im doing it by passing the objects rather than events
            //}

        }
        public void reattachLinkeElement(TElement newElement)
        {
            //step through bactive and find the element by name and source and relink the newelement.linkedElement
            lock (((ICollection)bActive.dataPacks).SyncRoot)
            {

                var bActiveQuery =
                    from a in bActive.dataPacks
                    where a.Src == newElement.elementSourceName && a.v == newElement.modversion
                    select a;
                if (bActiveQuery.Count() != 0)//if none of the existing packs matched the new pack then add it
                {

                    foreach (var matchingPack in bActiveQuery) //for each existing pack that was found to match the current new pack
                    {

                        var elementQuery =
                            from b in matchingPack.dataElement
                            where b.N == newElement.linkedElement.N
                            select b;

                        if (elementQuery.Count() != 0)//if the element didn't already exist add it to the active pack
                        {
                            foreach (var matchingElement in elementQuery)
                            {
                                newElement.linkedElement = matchingElement;
                            }

                        }



                    }

                }
            }
        }


        public void update1_00(DR bNew)//
        {
            /*Adds the new data to the master active bean list
             * There is FOR SURE a better way to do this... 
             */

                for (int c = 0; c < bNew.dataPacks.Count; c++)  // for each pack in the new list
                {
                    bool wasItThere = false;
                    if (bActive.dataPacks != null)  //so long as there is actually something there 

                    {
                        for (int i = 0; i < bActive.dataPacks.Count; i++) //does the specific new pack already exist (it's "by name")
                        {

                            if (bActive.dataPacks[i].Src == bNew.dataPacks[c].Src)  //if it exists then update the values
                            {


                                // element stuff below here
                                for (int d = 0; d < bNew.dataPacks[c].dataElement.Count; d++)  // for each pack in the new list
                                {
                                    bool wasItThere2 = false;
                                    if (bActive.dataPacks[i].dataElement != null)  //so long as there is actually something there 
                                    {
                                        for (int e = 0; e < bActive.dataPacks[i].dataElement.Count; e++) //does the specific new pack already exist (it's "by name")
                                        {

                                            if (bActive.dataPacks[i].dataElement[e].N == bNew.dataPacks[c].dataElement[d].N)  //if it exists then update the values
                                            {

                                                bActive.dataPacks[i].dataElement[e].V = bNew.dataPacks[c].dataElement[d].V;
                                                

                                                wasItThere2 = true;  //tag it as being there so it doesn't get added on at the end
                                            }

                                        }
                                    }

                                    if (wasItThere2 == false)  //if the specific new pack wasn't there then add it
                                    {
                                        bActive.dataPacks[i].dataElement.Add(bNew.dataPacks[c].dataElement[d]);
                                        newSourceData();
                                    }

                                }
                                //element stuff above here




                                bActive.dataPacks[i].LastHeardFrom = DateTime.Now;  // set the time at which it was updated
                                wasItThere = true;  //tag it as being there so it doesn't get added on at the end
                            }

                        }
                    }

                    if (wasItThere == false)  //if the specific new pack wasn't there then add it
                    {
                        bActive.dataPacks.Add(bNew.dataPacks[c]);
                        bActive.dataPacks[c].LastHeardFrom = DateTime.Now;
                        newSourceData();
                    }

                }

                if (packsAreUpdated != null) // will be null if no subscribers
                {
                    packsAreUpdated();  //global trigger for packs are updated, may be depreciated now that im doing it by passing the objects rather than events
                }

        }

        public DR reportActiveBeans()
        {
            return bActive;
        }
        public void clearPacks()
        {
            //simply clearing the packs messes with FORM1 source datagridview because of the way the last-updated variable works
            //need to eventually fix this by moving the lastupdated variable to the packs rather than calculating it in form1
            bActive.dataPacks.Clear();
        }

        //Dead methods
        public string reportSourceOfIndex(int index)
        {
            string source = bActive.dataPacks[index].Src;
            return source;
        }
        public string reportVersionOfIndex(int index)
        {
            string version = bActive.dataPacks[index].v;
            return version;
        }
        public int reportActiveSourceCount()
        {
            int count = bActive.dataPacks.Count();
            return count;
        }
        public string activeBeansToString() //is this really dead? I think it's used in the debugg screen
        {
            /*
             * Converts the current master bean list to XML and spits it out in a string
             */
            return CVRT.objectToXMLString(bActive);
        }

    }
}
