
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;

namespace cfg
{
public partial class Tables
{
    public Brick.TbBrick TbBrick {get; }
    public Character.CharacterDefine CharacterDefine {get; }
    public Character.WeaponDefine WeaponDefine {get; }
    public Bullet.BulletDefine BulletDefine {get; }

    public Tables(System.Func<string, JSONNode> loader)
    {
        TbBrick = new Brick.TbBrick(loader("brick_tbbrick"));
        CharacterDefine = new Character.CharacterDefine(loader("character_characterdefine"));
        WeaponDefine = new Character.WeaponDefine(loader("character_weapondefine"));
        BulletDefine = new Bullet.BulletDefine(loader("bullet_bulletdefine"));
        ResolveRef();
    }
    
    private void ResolveRef()
    {
        TbBrick.ResolveRef(this);
        CharacterDefine.ResolveRef(this);
        WeaponDefine.ResolveRef(this);
        BulletDefine.ResolveRef(this);
    }
}

}
