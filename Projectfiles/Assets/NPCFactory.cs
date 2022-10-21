using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCFactory : MonoBehaviour
    {
        public INPC GetNPC(NPCType type)
        {
            switch (type)
            {
                case NPCType.Beggar:
                    INPC beggar = new Beggar();
                    return beggar;
                case NPCType.Farmer:
                    INPC farmer = new Farmer();
                    return farmer;
                case NPCType.Shopowner:
                    INPC shopowner = new Shopowner();
                    return shopowner;
                case NPCType.Priest:
                    INPC priest = new Priest();
                    return priest;

                case NPCType.Apple:
                    INPC apple = new Apple();
                    return apple;
                case NPCType.Knife:
                    INPC knife = new Knife();
                    return knife;
                case NPCType.Table:
                    INPC table = new Table();
                    return table;
            }
            return null;
        }
    }
}
