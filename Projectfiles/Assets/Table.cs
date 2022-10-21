using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Table : INPC
    {
        public void Speak()
        {
            Debug.Log("Table:This is a table");
        }
    }
}