using System.ComponentModel.DataAnnotations;

namespace NiN3.Core.Models.Enums
{
    public enum ProsedyrekategoriEnum
    {
        [Display(Name = "Normal variasjonsbredde. Variasjon i artssammensetning ikke betinget av strukturerende artsgruppe. Lite endret system.")]
        A,
        [Display(Name = "Normal variasjonsbredde. Variasjon i artssammensetning betinget av strukturerende artsgruppe. Lite endret system.")]
        B,
        [Display(Name = "Spesiell variasjonsbredde. Variasjon i artssammensetning ikke betinget av strukturerende artsgruppe. Lite endret system. Preget av miljøstress.")]
        C,
        [Display(Name = "Spesiell variasjonsbredde. Variasjon i artssammensetning ikke betinget av strukturerende artsgruppe. Lite endret system. Preget av aktiv regulerende forstyrrelse .")]
        D,
        [Display(Name = "Spesiell variasjonsbredde. Variasjon i artssammensetning betinget av strukturerende artsgruppe. Lite endret system. Preget av aktiv destabiliserende forstyrrelse.")]
        E,
        [Display(Name = "Spesiell variasjonsbredde. Variasjon i artssammensetning betinget av strukturerende artsgruppe. Lite endret system. Preget av aktiv regulerende forstyrrelse .")]
        F,
        [Display(Name = "Spesiell variasjonsbredde. Ny mark eller bunn . Klart endret system. Preget av historisk forstyrrelse. . .")]
        G,
        [Display(Name = "Spesiell variasjonsbredde. Variasjon i artssammensetning betinget av bortfall av strukturerende artsgruppe. Klart endret system. Uten preg av hevd.")]
        H,
        [Display(Name = "Spesiell variasjonsbredde. Variasjon i artssammensetning betinget av strukturerende artsgruppe. Klart endret system. Uten preg av hevd.")]
        I,
        [Display(Name = "Spesiell variasjonsbredde. Klart endret system. Hevdpreget. Uten jordbruksproduksjon.")]
        J,
        [Display(Name = "Spesiell variasjonsbredde. Klart endret system. Hevdpreget. Semi-naturlig system. Med historisk dybde.")]
        K,
        [Display(Name = "Spesiell variasjonsbredde. Klart endret system. Hevdpreget. Semi-naturlig system. Uten historisk dybde.")]
        L,
        [Display(Name = "Spesiell variasjonsbredde. Ny mark eller bunn . Sterkt endret system. Uten preg av hevd.")]
        M,
        [Display(Name = "Spesiell variasjonsbredde. Sterkt endret system. Hevdpreget. Uten jordbruksproduksjon.")]
        N,
        [Display(Name = "Spesiell variasjonsbredde. Sterkt endret system. Hevdpreget. Jordbruksmark.")]
        O
    }
}
