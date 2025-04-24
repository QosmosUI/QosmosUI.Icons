// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiVibratingSmartphone : ComponentBase
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
		builder.AddAttribute(14, "d", "M134.5 30.5v451h243v-451h-243zm-44.41.5c-43.64 41-73.2 116-73.2 203.7 0 87.8 29.87 164 73.83 204.4C61.5 392.4 42.5 318.5 42.5 234.7 42.5 152 61.13 78 90.09 31zm331.81 0c28.9 47 47.6 121.1 47.6 203.8 0 83.8-19 157.7-48.2 204.3 43.9-40.3 73.8-116.5 73.8-204.3 0-87.7-29.6-162.8-73.2-203.8zM235.2 50.5h41.6a8 8 0 0 1 0 16h-41.6a8 8 0 0 1 0-16zM126 80c-37.75 24.9-64.74 85-64.74 154.7 0 70.4 27.11 130.3 65.14 154.8-25.5-30.3-42.84-88.2-42.84-154.8 0-66.4 17.14-124.8 42.44-154.7zm260 0c25.3 30 42.4 88.4 42.4 154.8 0 66.6-17.3 124.5-42.8 154.8 38-24.5 65.1-84.5 65.1-154.8 0-69.7-27-129.8-64.7-154.8zm-236.5 3.5h211v343h-211v-343zm105.3 349a19.26 19.26 0 0 1 20 19.3 19.26 19.26 0 0 1-19.3 19.2 19.26 19.26 0 0 1-.7-38.5z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
