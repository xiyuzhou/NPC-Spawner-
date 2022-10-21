using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Client : MonoBehaviour
    {
        public NPCSpawner m_SpawnerNPC;

        public void OnClickNPC()
        {
            m_SpawnerNPC.SpawnVillagers();
        }

        public void OnClickItem()
        {
            m_SpawnerNPC.SpawnItems();
        }
        //void OnGUI()
        //{
        //    GUI.color = Color.black;
        //    GUI.Label(new Rect(10, 10, 200, 20), "Press S to spawn NPCs.");
        //    GUI.Label(new Rect(10, 30, 300, 20), "Look in the Debug Console to see them speak.");
       // }
    }
}
