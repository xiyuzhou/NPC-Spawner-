using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFactory m_Factory;

        private INPC m_Farmer;
        private INPC m_Beggar;
        private INPC m_Shopowner;
        private INPC m_Priest;

        private INPC m_Apple;
        private INPC m_Knife;
        private INPC m_Table;

        public void SpawnVillagers()
        {
            /** 
            We don't want to specify the class to instiate for each type of villager.
            Instead, we ask the factory to "manufacture" it for us.
            **/

            m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
            m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
            m_Priest = m_Factory.GetNPC(NPCType.Priest);


            m_Beggar.Speak();
            m_Farmer.Speak();
            m_Shopowner.Speak();
            m_Priest.Speak();
        }
        public void SpawnItems()
        {
            m_Apple = m_Factory.GetNPC(NPCType.Apple);
            m_Knife = m_Factory.GetNPC(NPCType.Knife);
            m_Table = m_Factory.GetNPC(NPCType.Table);

            m_Apple.Speak();
            m_Knife.Speak();
            m_Table.Speak();
        }
    }
}
