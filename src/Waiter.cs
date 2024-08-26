using System.Collections;
using System.Runtime.CompilerServices;

namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un mozo en el restaurante, encargado de atender mesas.
/// </summary>
public class Waiter
{
    public string name;
    private ArrayList assignedTables = new ArrayList();

    public Waiter(string NameWaiter);
    {
        this.name = NameWaiter;

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
        int numTable = table.Number; //Revisar en el objeto Table
        if (assignedTables.Contains(numTable)) ;
        {
            table.AddToOrder(dish);
        }
    }
}
