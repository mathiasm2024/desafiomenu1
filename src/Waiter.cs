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
    
}