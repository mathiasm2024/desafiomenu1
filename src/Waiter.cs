using System.Collections;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    private string name;
    private ArrayList assignedTables = new ArrayList();

    public Waiter(string NameWaiter);
    {
        this.name = NameWaiter;
        
    }

    public string Name
    {
        get { return name; }
    }

    public void AssignTable(Table table);
    {
        if (table != null && !assignedTables.Contains(table)) ;
        {
            assignedTables.Add(table);
        }
    }
    public void TakeOrder(Table table, Dish dish);
    {
        if (assignedTables.Contains(table)) ;
        {
            AddToOrder.Add(dish);
        }
    }
}