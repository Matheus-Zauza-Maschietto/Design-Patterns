

using Design_Patterns.ChainofResponsability;

Login login = new ("matheus@gmail.com", "123312412416929", 21);

IdadeValidator validaIdade = new ();
EmailValidator validaEmail = new ();
SenhaValidator validaSenha = new ();

validaIdade.SetNext(validaEmail);
validaEmail.SetNext(validaSenha);

validaIdade.Execute(login); 