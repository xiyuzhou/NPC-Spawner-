using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class Knife : INPC
    {
        public void Speak()
        {
            Debug.Log("Knife: This is a knife");
        }
    }
}