using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace OpenNspw;

internal interface IAssetManager
{
	IReadOnlyDictionary<string, Texture2D> Textures { get; }
	IReadOnlyDictionary<string, SoundEffect> SoundEffects { get; }
}

// Code from: https://community.monogame.net/t/passing-the-contentmanager-to-every-class-feels-wrong-is-it/10470/12
internal sealed class AssetManager : IAssetManager
{
	public IReadOnlyDictionary<string, Texture2D> Textures { get; }
	public IReadOnlyDictionary<string, SoundEffect> SoundEffects { get; }

	private string GetProperMonoGameAssetPath(string path, string fileName, string rootDirectory)
	{
		return Path.Combine(path[(path.IndexOf(rootDirectory) + rootDirectory.Length)..], fileName).Replace('\\', '/').Substring(1);
	}

	private Dictionary<string, T> LoadAssets<T>(ContentManager content, string contentDirectory)
	{
		var directory = new DirectoryInfo(Path.Combine(content.RootDirectory, contentDirectory));
		if (!directory.Exists)
			throw new DirectoryNotFoundException();

		var ret = new Dictionary<string, T>();
		var files = directory.GetFiles("*.*", SearchOption.AllDirectories);
		foreach (var file in files)
		{
			var assetName = GetProperMonoGameAssetPath(file.DirectoryName ?? string.Empty, Path.GetFileNameWithoutExtension(file.Name), content.RootDirectory);
			ret.Add(assetName, content.Load<T>(assetName));
		}
		return ret;
	}

	public AssetManager(ContentManager content)
	{
		Textures = LoadAssets<Texture2D>(content, "Textures");
		SoundEffects = LoadAssets<SoundEffect>(content, "SoundEffects");
	}
}
