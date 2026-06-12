public class LaunchMailAction : ActionBase
{
	public string To;

	public string Subject;

	public bool MakeSubjectUnique;

	private string Url => null;

	private string UniqueSubjectSuffix => null;

	public override void Act()
	{
	}
}
