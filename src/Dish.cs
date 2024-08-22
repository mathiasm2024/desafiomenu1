namespace Ucu.Poo.Restaurant;

/// <summary>
/// Representa un platillo individual en el menú del restaurante.
/// </summary>
public class Dish
{
    private string name;
    private int price;
    private bool IsVegetarian;

    public Dish(string unnombre, int unprecio, bool unapregunta)
    {
        this.name = unnombre;
        this.price = unprecio;
        this.IsVegetarian = unapregunta;
    }
}