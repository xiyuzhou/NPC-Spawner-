using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Apple : INPC
    {
        public void Speak()
        {
            Debug.Log("Apple: This is a apple.");
        }
    }
}