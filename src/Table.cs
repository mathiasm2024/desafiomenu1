namespace Ucu.Poo.Restaurant;

using System.Collections;

/// <summary>
/// Representa una mesa en el restaurante.
/// </summary>
public class Table
{

    public int Number;
    public bool IsOccupied;


    private ArrayList order = new ArrayList();
    public bool HasOrders()
    {
        return this.order.Count > 0;
    }



    public void Occupy()
    {
        this.IsOccupied = true;
    }

    public Table(int UnNumero)
    {
        this.Number = UnNumero;
        this.IsOccupied = false;
    }
        
    public void Ocupy()
    {
        this.IsOccupied = true;

    }

    public void Free()
    {


        this.IsOccupied = false;
        this.order.Clear(); 
    }

    public void AddToOrder(Dish Plato)
    {
        this.order.Add(Plato);
    }
    
}