using System;
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
                //may need to add threading?? doesn't seem to improve anything.
                //var thread = new Thread(
                //    () => update1_00(dIncoming));
                //thread.Start();

                //alternatively use this, but still no improvement.
                //Task.Factory.StartNew(() => update1_00(dIncoming));

                update1_00(dIncoming);

            }
        }

        public void update1_00(DR bNew)
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
        public void clearPacls()
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
        public string activeBeansToString()
        {
            /*
             * Converts the current master bean list to XML and spits it out in a string
             */
            return CVRT.objectToXMLString(bActive);
        }

    }
}
