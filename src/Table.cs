namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{
    private int Number;
    private bool IsOccupied;
    private ArrayList order = new ArrayList();
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }


    public void Occupy()
    {
        this.IsOccupied = True;
    }

    public void Free()
    {
        this.IsOccupied = False;
        this.order.Clear(); 
    }

    public void AddToOrder(Dish Plato)
    {
        this.order.Add(Plato);
    }
    
}