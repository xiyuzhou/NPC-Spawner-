using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Priest : INPC
    {
        public void Speak()
        {
            Debug.Log("Priest: How I can help you?");
        }
    }
}