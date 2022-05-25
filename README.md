**- String es una tipo por valor o un tipo por referencia?**

String es un tipo de variable por referencia cuyo valor asignado no puede ser modificado. La unica forma de para cambiar la misma variable es creando una nueva cadena de caracteres y obligar que la referencia apunte a la nueva.

**- Qué secuencias de escape tiene el tipo string?**

\' -> Comilla simple.

\" -> Comilla doble.

\  -> Barra invertida.

\n -> Nueva linea.

\r -> Retorno de carro.

\u -> Escape Unicode.

**- ¿Qué sucede cuando se utiliza el caracter @ y $ antes de una cadena de texto?**

$ se utiliza para interpolar cadenas.

@ se utiliza para crear una llamada cuya cadena debe ser interpretada de manera literal. 

**- Busque el comportamiento del Método ToString**

Object.ToString es el principal método de formato en .NET Framework. Convierte un objeto a su representación de cadena para que sea adecuado para su visualización.