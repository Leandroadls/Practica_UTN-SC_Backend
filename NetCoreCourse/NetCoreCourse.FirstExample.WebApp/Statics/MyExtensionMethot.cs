namespace NetCoreCourse.FirstExample.WebApp.Statics
{
    public static class MyExtensionMethot
    {
        public static string PrimeraMaysucula(this string fraseInicial)
        {
            char primeraLetra = char.ToUpper(fraseInicial[0]);
            string RestoDeFrase = fraseInicial.Substring(1);

            return primeraLetra + RestoDeFrase;
        }
    }
}


