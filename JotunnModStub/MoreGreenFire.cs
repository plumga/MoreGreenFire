// JotunnModStub
// a Valheim mod skeleton using Jötunn
// 
// File:    JotunnModStub.cs
// Project: JotunnModStub

using BepInEx;
using UnityEngine;
using BepInEx.Configuration;
using Jotunn.Configs;
using Jotunn.Managers;
using Jotunn.Entities;
using Jotunn.Utils;

namespace MoreGreenFire
{
    [BepInPlugin(PluginGUID, PluginName, PluginVersion)]
    [BepInDependency(Jotunn.Main.ModGuid)]
    internal class MoreGreenFire : BaseUnityPlugin
    {
        public const string PluginGUID = "com.jotunn.plumga.MoreGreenFire";
        public const string PluginName = "MoreGreenFire";
        public const string PluginVersion = "0.0.1";
        private AssetBundle greenfire;


        private void Awake()
        {

            LoadAssets();
            GreenBrazier();
            GreenWoodTorch();
            GreenSconce();
           // IronTest();


        }

         


        private void LoadAssets()
        {
            greenfire = AssetUtils.LoadAssetBundleFromResources("greenfire", typeof(MoreGreenFire).Assembly);

        }


     //   public void LoadgameFabs()
      //  {
        //    try
          //  {
                //vfx
                ///   var fuelwalltorch = PrefabManager.Cache.GetPrefab<GameObject>("vfx_walltorch_addFuel");
                ///   var placebrazier = PrefabManager.Cache.GetPrefab<GameObject>("vfx_Place_brazierceiling01");
                ///   var fuelgroundtorch = PrefabManager.Cache.GetPrefab<GameObject>("vfx_groundtorch_addFuel");
                ///   var fireaddfuel = PrefabManager.Cache.GetPrefab<GameObject>("vfx_FireAddFuel");

                //sfx
                ///   var fireaddfuelsfx = PrefabManager.Cache.GetPrefab<GameObject>("sfx_FireAddFuel");

                //sounds
                ///  var fireloop = PrefabManager.Cache.GetPrefab<GameObject>("Fire_Loop03");
             ///   var fireloop2 = $custompiece_groundtorch_wood_greenprefab.GetComponentInChildren<Zsfx>("$custompiece_groundtorch_wood_green");

                //og
                // var camshakeblock = PrefabManager.Cache.GetPrefab<GameObject>("fx_block_camshake");
                // var sfxhammer = PrefabManager.Cache.GetPrefab<GameObject>("sfx_build_hammer_wood");
                // var vfx_Place_wood_pole = PrefabManager.Cache.GetPrefab<GameObject>("vfx_Place_wood_pole");


                ///  fuelsounds = new EffectList { m_effectPrefabs = new EffectList.EffectData[2] { new EffectList.EffectData { m_prefab = fireaddfuelsfx }, new EffectList.EffectData { m_prefab = fireaddfuel } } };

                // effecthit = new EffectList { m_effectPrefabs = new EffectList.EffectData[3] { new EffectList.EffectData { m_prefab = hitsparks, m_enabled = true }, new EffectList.EffectData { m_prefab = sfxhitsword, m_enabled = true }, new EffectList.EffectData { m_prefab = camshake, m_enabled = true } } };
                //effectblocked = new EffectList { m_effectPrefabs = new EffectList.EffectData[3] { new EffectList.EffectData { m_prefab = sfxblocked }, new EffectList.EffectData { m_prefab = vfxblock, m_enabled = true }, new EffectList.EffectData { m_prefab = camshakeblock, m_enabled = true } } };
                //  trigger = new EffectList { m_effectPrefabs = new EffectList.EffectData[1] { new EffectList.EffectData { m_prefab = camshake, m_enabled = true } } };
                ///  firesounds = new EffectList { m_effectPrefabs = new EffectList.EffectData[1] { new EffectList.EffectData { m_prefab = fireloop, m_enabled = true } } };
          ///      firesounds2 = new EffectList { m_effectPrefabs = new EffectList.EffectData[1] { new EffectList.EffectData { m_prefab = fireloop2, m_enabled = true } } };

          //      Jotunn.Logger.LogMessage("Loaded Game VFX and SFX");


       //  finally
       //     {
        //        ItemManager.OnVanillaItemsAvailable -= LoadgameFabs;
        //    }
      //  }
      ///I GIVE UP ON SOUNDS!! WE CAN JUST HAVE SILENT FIRE OKAY


        private void GreenBrazier() //done
        {
            var BrazFab = greenfire.LoadAsset<GameObject>("$custompiece_brazierceiling01_green");
                                                                                          
            var Braz = new CustomPiece(BrazFab,
                new PieceConfig
                {
                    PieceTable = "_HammerPieceTable",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Bronze", Amount = 5, Recover = true},
                        new RequirementConfig {Item = "Coal", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Chain", Amount = 1, Recover = true},
                        new RequirementConfig {Item = "Guck", Amount = 2, Recover = true}
                    }
                });

           // var itemDrop = BrazFab.ItemDrop;
          //  itemDrop.m_itemData.m_shared.m_hitEffect = firesounds;


            PieceManager.Instance.AddPiece(Braz);
        }

        private void GreenWoodTorch() //done
        {
            var woodfab = greenfire.LoadAsset<GameObject>("$custompiece_groundtorch_wood_green");

            var wood = new CustomPiece(woodfab,
                new PieceConfig
                {
                    PieceTable = "_HammerPieceTable",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Resin", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Blueberries", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(wood);
        }


        private void GreenSconce() //done
        {
            var sconcefab = greenfire.LoadAsset<GameObject>("$custompiece_walltorch_green");

            var sconce = new CustomPiece(sconcefab,
                new PieceConfig
                {
                    PieceTable = "_HammerPieceTable",
                    AllowedInDungeons = false,
                    Requirements = new[]
                    {
                        new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Copper", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Resin", Amount = 2, Recover = true},
                        new RequirementConfig {Item = "Blueberries", Amount = 2, Recover = true}
                    }
                });
            PieceManager.Instance.AddPiece(sconce);
        }

       // private void IronTest() //done
     //   {
      //      var testfab = greenfire.LoadAsset<GameObject>("$piece_groundtorch_green_duplicate");

      //      var test = new CustomPiece(testfab,
      //          new PieceConfig
       //         {
       //             PieceTable = "_HammerPieceTable",
         //           AllowedInDungeons = false,
           //         Requirements = new[]
             //       {
               //         new RequirementConfig {Item = "Wood", Amount = 2, Recover = true},
                 //       new RequirementConfig {Item = "Copper", Amount = 2, Recover = true},
                   //     new RequirementConfig {Item = "Guck", Amount = 2, Recover = true}
    //                }
      //          });
        //    PieceManager.Instance.AddPiece(test);
       // }




        // to here 

    }
}