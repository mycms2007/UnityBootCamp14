using UnityEngine;

//인터페이스(interface)

public interface IThrowable
{

}

public interface IWeapon
{

}

public interface ICountable
{
    

}

public interface IPotion
{


}

public interface IUsable { }

public class Item { }


public class sword : Item, IWeapon { }
public class Jabelin : Item, IWeapon, IPotion, ICountable, IThrowable { }

public class Maxpotion : Item, ICountable, IUsable { }

public class FirePotion : Item, IPotion, ICountable, IThrowable { }
public class InterSample : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
