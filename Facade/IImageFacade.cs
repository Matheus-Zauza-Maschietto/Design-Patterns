using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Facade;

public interface IImageFacade
{
    void RecortarImagem(string path, double width, double height);
    void WhiteBlackImage(string path);
}
