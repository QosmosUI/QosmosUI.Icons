// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiFloorHatch : ComponentBase
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
		builder.AddAttribute(14, "d", "M110.297 71.817l-46.71 12.936c35.32 100.342 82.123 195.39 131.653 297.3L328.656 395.7c-.385-33.58-4.508-74.918-15.427-113.043 33.89-49.694 60.607-111.009 92.484-176.203l-38.858-27.77c-23.013 55.262-46.325 111.084-81.988 163.829-9.005 11.141-91.217 8.963-99.012 1.814-29.931-62.736-58.224-112.585-75.558-172.51zm115.455 42.623a27.02 27.02 0 0 0-3.815.239c-10.15 1.36-19.012 8.385-25.21 20.197-6.2 11.812-9.199 28.107-6.866 45.525 2.333 17.42 9.515 32.35 18.604 42.114 9.088 9.764 19.487 14.209 29.637 12.85 10.15-1.36 19.01-8.385 25.209-20.196 6.198-11.812 9.196-28.107 6.863-45.525-2.333-17.42-9.511-32.35-18.6-42.114-7.952-8.543-16.908-13.016-25.822-13.09zM136.01 292.354L19.03 400.78l19.779 2.037 363.03 37.366 91.132-143.526-158.051-3.523c1.58 6.018 2.944 12.051 4.154 18.095l121.602 2.711-68.067 107.198-332.175-34.192 82.84-76.785c-2.457-5.934-4.88-11.87-7.264-17.807z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
