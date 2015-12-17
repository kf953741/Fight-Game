using UnityEditor;
using UnityEngine;
using System.Collections;

public class ImportTool : AssetPostprocessor
{

    void OnPreprocessTexture()
    {
        string packingTag = new System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(assetPath)).Name;

        TextureImporter myTexture = AssetImporter.GetAtPath(assetPath) as TextureImporter;
        string floder = System.IO.Path.GetDirectoryName(assetPath);
        floder = floder.Replace('\\', '/');
        if (floder.Contains("Assets/UI/") && !floder.Equals("Assets/UI/texture") && !floder.Equals("Assets/UI/texture/xuanchuantu") && !floder.Equals("Assets/UI/texture/share"))
        {
            myTexture.textureType = TextureImporterType.Sprite;
            myTexture.spriteImportMode = SpriteImportMode.Single;
            myTexture.spritePackingTag = packingTag;
            myTexture.mipmapEnabled = false;
            myTexture.filterMode = FilterMode.Bilinear;
            myTexture.SetPlatformTextureSettings("Android", 1024, TextureImporterFormat.RGBA32, 100);
            myTexture.SetPlatformTextureSettings("Standalone", 1024, TextureImporterFormat.RGBA32, 100);
            myTexture.SetPlatformTextureSettings("iPhone", 1024, TextureImporterFormat.RGBA32, 100);
        }

    }
    void OnPostprocessTexture (Texture2D texture) 
    {
        string packingTag =new System.IO.DirectoryInfo(System.IO.Path.GetDirectoryName(assetPath)).Name;
        
        TextureImporter myTexture = AssetImporter.GetAtPath(assetPath) as TextureImporter;
        string floder = System.IO.Path.GetDirectoryName(assetPath);
        floder= floder.Replace('\\', '/');
        if (floder.Contains("Assets/UI/")&&!floder.Equals("Assets/UI/texture")&&!floder.Equals("Assets/UI/texture/xuanchuantu")&&!floder.Equals("Assets/UI/texture/share"))
        {
            myTexture.textureType = TextureImporterType.Sprite;
            myTexture.spriteImportMode = SpriteImportMode.Single;
            myTexture.spritePackingTag = packingTag;
            myTexture.mipmapEnabled = false;
            myTexture.filterMode = FilterMode.Bilinear;

            myTexture.SetPlatformTextureSettings("Android", 1024, TextureImporterFormat.RGBA32, 100);
            myTexture.SetPlatformTextureSettings("Standalone", 1024, TextureImporterFormat.RGBA32, 100);
            myTexture.SetPlatformTextureSettings("iPhone", 1024, TextureImporterFormat.RGBA32, 100);
        }
    }

    // private void On

    /// <summary>
    /// 音频导入默认设置
    /// </summary>
    private void OnPreprocessAudio()
    {
        AudioImporter myAudio = AssetImporter.GetAtPath(assetPath) as AudioImporter;
        myAudio.format = AudioImporterFormat.Compressed;
        myAudio.loadType = AudioImporterLoadType.CompressedInMemory;
        myAudio.threeD = false;
    }
    /// <summary>
    /// 模型导入的默认设置
    /// </summary>
//    private void OnPreprocessModel()
//    {
//        ModelImporter myModel = AssetImporter.GetAtPath(assetPath) as ModelImporter;
//        myModel.meshCompression = ModelImporterMeshCompression.Off;
//        myModel.isReadable = true;
//        myModel.optimizeMesh = true;
//        myModel.importBlendShapes = true;
//        myModel.normalImportMode = ModelImporterTangentSpaceMode.Import;
//        myModel.tangentImportMode = ModelImporterTangentSpaceMode.Calculate;
//        myModel.importMaterials = true;
//        myModel.materialName = ModelImporterMaterialName.BasedOnTextureName;
//        myModel.materialSearch = ModelImporterMaterialSearch.RecursiveUp;
//        myModel.importAnimation = true;
//    }

}
