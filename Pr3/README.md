# Práctica 3: Delegados, eventos

### Esta práctica consiste en realizar cuatro ejercicios utilizando delegados y eventos.
-----------------------------------

### **Primer ejercicio**
>Cuando el jugador colisiona con un objeto de tipo B, el objeto A mostrará un texto en una UI de Unity. Cuando toca el objeto A se incrementará la fuerza del objeto B.


### **Segundo ejercicio**
>Cuando el jugador se aproxima a los cilindros de tipo A, los cilindros de tipo B cambian su color y las esferas se orientan hacia un objetivo ubicado en la escena con ese propósito. Consultar información de la clase Vector3: *LookAt, RotateTowards, ...*

### **Tercer ejercicio**
>Implementar un controlador que mueva el objeto con *wasd*.

Para la implementación de este ejercicio he reutilizado el script que había implementado para la práctica anterior.

### **Cuarto ejercicio**
>uscar información de *[Debug.DrawRay](https://docs.unity3d.com/ScriptReference/Debug.DrawRay.html)* y utilízala para depuración.

La clase *Debug* contiene métodos para facilitar la depuración mientras se desarrolla un juego. El método *DrawRay* de esta clase dibuja una línea recta, al cual debemos pasarle tres parámetros. El primero representa la posición del comienzo de la línea, el segundo la posición del final de la línea, y por último el color de la línea.

Este método ha sido de utilidad para comprobar que nuestras esferas estaban siguiendo la dirección correcta en el ejercicio anterior.


<br />
<br />


--------------------
Esta práctica ha sido realizada por Nerea Rodríguez Hernández 💻, alu0101215693@ull.edu.es, alumna de Ingenería Informática en la Universidad de La Laguna para la asignatura de Interfaces Inteligentes📚.