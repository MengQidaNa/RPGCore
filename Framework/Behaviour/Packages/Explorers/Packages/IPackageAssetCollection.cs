using System.Collections.Generic;

namespace RPGCore.Behaviour.Packages
{
	public interface IPackageAssetCollection : IEnumerable<PackageAsset>
	{
		PackageAsset this[string key] { get; }

		void Add (PackageAsset folder);
	}
}
