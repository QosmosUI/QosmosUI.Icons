// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiMeatCleaver : ComponentBase
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
		builder.AddAttribute(14, "d", "M312.813 24.313L88.5 282.938l65.563 95.718c90.372-68.07 182.097-177.937 254.843-295.844l-96.094-58.5zm9.125 30.03c2.658.03 4.815.813 6.562 2 3.494 2.376 6.438 7.41 6.438 16.376 0 17.928-14.45 41.012-29.657 48.124-7.603 3.555-12.692 2.844-16.186.47-3.494-2.377-6.47-7.412-6.47-16.376 0-17.93 14.48-41.014 29.688-48.126 3.803-1.777 6.967-2.5 9.625-2.468zm102.937 38.188c-73.88 119.784-166.747 231.365-260.25 301.564l42.53 62.125c93.965-68.158 219.3-202.6 281.564-324.845L424.874 92.53zM73.5 294.126c-17.832 17.12-35.684 32.712-53.563 46.844V461.56c27.78-33.634 57.404-75.49 87.75-117.53L73.5 294.124z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
