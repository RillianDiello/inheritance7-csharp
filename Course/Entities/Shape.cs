using Course.Entities.Enums;

namespace Course.Entities
{
// Sempre que eu tenho um método abstrato eu devo aplicar o conceito de abstrato a toda a classe
// Por isso abstract na classe e protected no construtor
    abstract class Shape
    {
        public Color Color { get; set; }

        // A classe tem um construtor protected pois vai pode ser utilizado pelas classes filhas
        protected Shape(Color color)
        {
            Color = color;
        }

        public abstract double Area(); 
        // public abstract
        // A operação de area é uma operação abstrata que não existe um unico formato de calculo
        // Portanto faz sentido que ela seja um metodo abstrato, em q cada filho faça a sua implementação

    }
}
