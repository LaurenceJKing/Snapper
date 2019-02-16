namespace Snapper.Core
{
    internal class SnapshotId
    {
        public string FilePath { get; }
        public string PartialId { get; }

        public SnapshotId(string filePath, string partialId = null, string secondaryId = null)
        {
            FilePath = filePath;
            PartialId = partialId;
        }
    }
}