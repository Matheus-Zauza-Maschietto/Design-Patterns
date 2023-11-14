using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Facade;

public class ImageFacade: IImageFacade
{
    public void RecortarImagem(string path, double width, double height)
    {
        System.Console.WriteLine("Imagine a imagem recordatada");
    }

    public void WhiteBlackImage(string path)
    {
        System.Console.WriteLine("Imagine uma imagem preta e branca !!!.");
    }
}
