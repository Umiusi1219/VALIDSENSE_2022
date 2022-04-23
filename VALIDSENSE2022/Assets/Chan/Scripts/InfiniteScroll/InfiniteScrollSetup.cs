using UnityEngine;

public interface InfiniteScrollSetup
{
	void OnPostSetupItems();
	void OnUpdateItem(int itemCount, GameObject obj);
}
