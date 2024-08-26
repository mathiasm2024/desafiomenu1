namespace Ucu.Poo.Restaurant;
    using System.Collections;

    /// <summary>
    /// Representa el conjunto de platillos <see cref="Dish"/> disponibles en el
    /// restaurante.
    /// </summary>
    public class Menu
    {
        private ArrayList dishes = new ArrayList();

        //dishes lista de platillos
        public void AddDish(Dish platoAñadir)
        {
            dishes.Add(platoAñadir);
        }

        public void RemoveDish(Dish platoBorrado)
        {
            dishes.Remove(platoBorrado);
        }

        public Dish GetDishByName(string nombre)
        {
            foreach (Dish plato in dishes)
            {
                if (plato.GetName() == nombre.ToLower())
                {
                    return plato;
                }
            }

            return null;
        }
    }