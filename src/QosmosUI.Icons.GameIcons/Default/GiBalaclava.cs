// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiBalaclava : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "1em";

    [Parameter]
    public string Stroke { get; set; } = "currentColor";

    [Parameter]
    public string Fill { get; set; } = "currentColor";

    [Parameter]
    public string StrokeWidth { get; set; } = "0";

    [Parameter]
    public string StrokeLinecap { get; set; } = "round";

    [Parameter]
    public string StrokeLinejoin { get; set; } = "round";

    [Parameter]
    public string ViewBox { get; set; } = "0 0 512 512";

    [Parameter(CaptureUnmatchedValues = true)]
    public IReadOnlyDictionary<string, object>? AdditionalAttributes { get; set; }

    protected override void BuildRenderTree(RenderTreeBuilder builder)
    {
        builder.OpenElement(0, "svg");
        builder.AddAttribute(1, "xmlns", "http://www.w3.org/2000/svg");
        builder.AddAttribute(2, "viewBox", ViewBox);
        builder.AddAttribute(3, "width", Size);
        builder.AddAttribute(4, "height", Size);
        builder.AddAttribute(5, "fill", Fill);
        builder.AddAttribute(6, "stroke", Stroke);
        builder.AddAttribute(7, "stroke-width", StrokeWidth);
        builder.AddAttribute(8, "stroke-linecap", StrokeLinecap);
        builder.AddAttribute(9, "stroke-linejoin", StrokeLinejoin);
        builder.AddMultipleAttributes(10, AdditionalAttributes);
        if (!string.IsNullOrEmpty(Title))
        {
            builder.OpenElement(11, "title");
            builder.AddContent(12, Title);
            builder.CloseElement();
        }
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M390.311 366.216C384.752 433.264 326.724 486 255.95 486c-70.775 0-128.803-52.736-134.363-119.784q4.26 7.76 8.918 15.07c33.406 52.275 77.961 81.064 125.435 81.064 47.473 0 92.038-28.789 125.445-81.094q4.668-7.27 8.927-15.04zm23.63-163.305c0 61.673-16.893 123.48-46.348 169.56C337.3 419.874 297.648 445.97 256 445.97c-41.648 0-81.34-26.107-111.593-73.498-29.455-46.07-46.347-107.887-46.347-169.56 0-47.095 13.063-90.156 36.774-121.218C162.538 45.268 204.452 26 255.95 26s93.441 19.247 121.227 55.674c23.7 31.072 36.754 74.122 36.754 121.227zm-175.847 1.024c1.29-7.822-56.995-27.069-73.713-29.823-16.719-2.754-27.97-4.095-30.714 12.593a30.632 30.632 0 0 0 25.237 35.218c16.698 2.785 77.859-9.92 79.18-17.957zm73.928 135.612c0-11.262-18.981-20.302-56.073-20.302s-56.073 9.091-56.073 20.302c0 11.21 18.98 20.301 56.073 20.301 37.092 0 56.073-9.06 56.073-20.27zm66.209-152.812c-2.754-16.698-14.037-15.357-30.714-12.592-16.678 2.764-74.983 22.001-73.713 29.823 1.32 8.037 62.451 20.732 79.18 17.978a30.632 30.632 0 0 0 25.247-35.209z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
