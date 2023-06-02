using System.ComponentModel.DataAnnotations;

namespace NiN3.Core.Models.Enums
{
    public enum MaalestokkEnum
    {
//        [Display(Name = "grunntype")]
//        G,
        [Display(Name = "kartleggingsenhet tilpasset 1:5000")]
	    M005,
        [Display(Name = "kartleggingsenhet tilpasset 1:10 000")]
	    M010,
        [Display(Name = "kartleggingsenhet tilpasset 1:20 000")]
	    M020,
        [Display(Name = "kartleggingsenhet tilpasset 1:50 000")]
	    M050,
        [Display(Name = "kartleggingsenhet tilpasset 1:100 000")]
	    M100
    }
}
