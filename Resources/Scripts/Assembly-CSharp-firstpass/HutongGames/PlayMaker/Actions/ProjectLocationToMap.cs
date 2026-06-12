namespace HutongGames.PlayMaker.Actions
{
	[ActionCategory(ActionCategory.Device)]
	[Tooltip("Projects the location found with Get Location Info to a 2d map using common projections.")]
	public class ProjectLocationToMap : FsmStateAction
	{
		public enum MapProjection
		{
			EquidistantCylindrical = 0,
			Mercator = 1
		}

		[Tooltip("Location vector in degrees longitude and latitude. Typically returned by the {{Get Location Info}} action.")]
		public FsmVector3 GPSLocation;

		[Tooltip("The projection used by the map.")]
		public MapProjection mapProjection;

		[Tooltip("The minimum Longitude shown on the map.")]
		[ActionSection("Map Region")]
		[HasFloatSlider(-180f, 180f)]
		public FsmFloat minLongitude;

		[Tooltip("The maximum Longitude show on the map.")]
		[HasFloatSlider(-180f, 180f)]
		public FsmFloat maxLongitude;

		[HasFloatSlider(-90f, 90f)]
		[Tooltip("The minimum Latitude shown on the map.")]
		public FsmFloat minLatitude;

		[HasFloatSlider(-90f, 90f)]
		[Tooltip("The maximum Latitude shown on the map.")]
		public FsmFloat maxLatitude;

		[ActionSection("Screen Region")]
		[Tooltip("The screen coordinate of the left edge of the map image.")]
		public FsmFloat minX;

		[Tooltip("The screen coordinate of the top edge of the map image.")]
		public FsmFloat minY;

		[Tooltip("The width of the map image in screen coordinates.")]
		public FsmFloat width;

		[Tooltip("The height of the map in screen coordinates.")]
		public FsmFloat height;

		[Tooltip("Store the projected X coordinate in a Float Variable. Use this to display a marker on the map.")]
		[UIHint(UIHint.Variable)]
		[ActionSection("Projection")]
		public FsmFloat projectedX;

		[Tooltip("Store the projected Y coordinate in a Float Variable. Use this to display a marker on the map.")]
		[UIHint(UIHint.Variable)]
		public FsmFloat projectedY;

		[Tooltip("If true all coordinates in this action are normalized (0-1); otherwise coordinates are in pixels.")]
		public FsmBool normalized;

		[Tooltip("Repeat every frame.")]
		public bool everyFrame;

		private float x;

		private float y;

		public override void Reset()
		{
		}

		public override void OnEnter()
		{
		}

		public override void OnUpdate()
		{
		}

		private void DoProjectGPSLocation()
		{
		}

		private void DoEquidistantCylindrical()
		{
		}

		private void DoMercatorProjection()
		{
		}

		private static float LatitudeToMercator(float latitudeInDegrees)
		{
			return 0f;
		}
	}
}
