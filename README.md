# Calculadora básica – Windows Forms (C#)

**U4 – Entrega de actividad** · Programación I · Universidad Tecnológica de El Salvador (UTEC) · Ciclo 02-2026

| Dato | Detalle |
| --- | --- |
| Nombre completo | Francisco Arnoldo Sánchez Melgar |
| Número de carné | 29-3681-2018 |

## Descripción

Calculadora básica hecha en Visual Studio Community con Windows Forms (.NET Framework 4.8), a partir del ejemplo práctico de la clase *"U4 – Ejemplo práctico: Calculadora básica"*.

El ejercicio consistía en completar el funcionamiento de los botones **RESTAR** y **MULTIPLICAR**. La calculadora queda con las cuatro operaciones:

- **SUMAR:** `num1 + num2`
- **RESTAR:** `num1 - num2`
- **MULTIPLICAR:** `num1 * num2`
- **DIVIDIR:** `num1 / num2`, con validación para no dividir entre cero

Antes de cada operación, el método `verificar_Contenido()` revisa con el `ErrorProvider` (`ErrorEncontrado`) que los dos `TextBox` no estén vacíos y que tengan valores numéricos. El resultado se muestra en un `MessageBox`.

## Estructura

```
CalculadoraBasica.sln
CalculadoraBasica/
├── Form1.cs              ← lógica de los botones (Sumar, Restar, Multiplicar, Dividir)
├── Form1.Designer.cs     ← diseño del formulario
├── Program.cs
└── Properties/
```

## Código de los botones completados

```csharp
private void btn_restar_Click(object sender, EventArgs e)
{
    if (!verificar_Contenido())
        return;

    double num1 = double.Parse(txtnum1.Text);
    double num2 = double.Parse(txtnum2.Text);

    double resultado = num1 - num2;

    MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
}

private void btn_multiplicar_Click(object sender, EventArgs e)
{
    if (!verificar_Contenido())
        return;

    double num1 = double.Parse(txtnum1.Text);
    double num2 = double.Parse(txtnum2.Text);

    double resultado = num1 * num2;

    MessageBox.Show("Resultado: " + resultado, "RESPUESTA", MessageBoxButtons.OK, MessageBoxIcon.Information);
}
```

## Cómo ejecutarlo

1. Clonar el repositorio o descargarlo.
2. Abrir `CalculadoraBasica.sln` en Visual Studio Community.
3. Presionar **F5** (Iniciar).
