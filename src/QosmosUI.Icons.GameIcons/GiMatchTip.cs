// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiMatchTip : ComponentBase
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
		builder.AddAttribute(14, "d", "M310.867 16.785L258.89 101.47l-51.976-58.402 2.188 102.407 19.962-46.123L251.2 171.03l23.19-28.46 3.16 60.08 80.108-64.298-48.486 91.705 47.433 21.08-38.93 15.894 69.548 110.654-80.776-52.3 5.45 36.505-44.467-49.445-30.987 73.61-12.482-85.963-41.273 26.937 1.053-46.378-83.27 6.323 82.218-40.055-88.542-29.512 43.772-19.898-117.313 11.42 89.94 43.8-79.426 55.48 95.778 4.675-34.46 57.232 57.82-26.863L131 453.262l77.66-93.657 18.69 129.067 33.287-100.45 93.285 84.055-23.957-83.273 136.207 68.642-78.377-138.935 81.11 9.827-75.325-68.94 80.225-31.98-94.026-21.025 43.8-50.225-61.32 16.936 43.803-112.13-98.7 85.85 3.504-130.238zM18.854 18.537v42.535c38.127 46.536 115.7 118.404 184.445 166.92-2.49 15.173 4.22 33.952 18.917 48.65 21.02 21.02 50.402 25.723 65.623 10.503 15.222-15.223 10.518-44.604-10.504-65.625-13.795-13.795-31.19-20.562-45.82-19.284-49.03-67.528-121.705-143.93-172.71-183.7H18.855z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
