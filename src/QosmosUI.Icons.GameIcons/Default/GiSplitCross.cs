// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiSplitCross : ComponentBase
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
		builder.AddAttribute(14, "d", "M96.375 20.094l30.813 40.75 130.28 130.28L375.313 73.282l40.22-53.186-159.594 108.094L96.375 20.094zM452.22 59.53l-113.564 76.845-74.562 74.563-6.594 6.625-6.625-6.625L176.937 137 62.594 59.625l80.844 119.47 69.656 69.655 6.594 6.594-6.594 6.625-74.813 74.81L61.563 450.19l120.75-81.688 68.657-68.656 6.593-6.625 6.625 6.624 69.562 69.562 119.53 80.906-77.374-114.343-73.937-73.94-6.595-6.592 6.594-6.625 68.56-68.563 81.69-120.72zm-430 34.69l108.124 159.593L22.22 413.375l53.468-40.438L193.25 255.375 62.812 124.937 22.22 94.22zm470.624 3.155l-53.22 40.22-117.812 117.843 130.47 130.468 40.53 30.656L384.72 256.97 492.843 97.374zm-235.28 222.28l-117.69 117.69-40.343 53.342 159.595-108.093 159.563 108.094L388 450.094 257.562 319.656z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
