using GameCharacters.Models;
using GameCharacters.Repozitorys;
using GameCharacters.Repozitorys.Inteface;
using Ninject;

using (IKernel kernel = new StandardKernel())
{
    kernel.Bind<IHero>().To<Archer>();
    kernel.Bind<IHero>().To<Infantryman>();
    kernel.Bind<IHero>().To<Spear>();
    kernel.Bind<IRepozitory>().To<Repozitory>();
    kernel.Bind<IGameInfo>().To<GemeInfo>();
    var hero = kernel.Get<IGameInfo>();

    hero.Display();
    hero.DisplayAttack();
    hero.SaveFile();

}