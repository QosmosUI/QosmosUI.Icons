// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Ionicons.Default;

public class IoAlarmSharp : ComponentBase
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
		builder.AddAttribute(14, "d", "M403.79,64.11l-3.27-.1H400c-14.73,0-28.55,5.91-40.52,15S344,96,344,96l88,86s11.25-5.71,17.61-13.85,14.28-18.08,14.32-37.11C464,95.55,437.6,66.15,403.79,64.11Z");
		builder.CloseElement();
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M108.21,64.11l3.27-.1H112c14.73,0,28.55,5.91,40.52,15S168,96,168,96L80,182s-11.25-5.71-17.61-13.85S48.11,150.07,48.07,131C48,95.55,74.4,66.15,108.21,64.11Z");
		builder.CloseElement();
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "d", "M391.3,384.6a.06.06,0,0,1,0-.08C425,344,441,288.24,427,229.23c-13.64-57.52-72.67-115.69-130.34-128.66C182,74.79,80.07,161.71,80.07,272a175.15,175.15,0,0,0,40.78,112.52.06.06,0,0,1,0,.08L73,432a.06.06,0,0,0,0,.08L96,454.59a.06.06,0,0,0,.08,0l47.43-47.37a.06.06,0,0,1,.08,0,175.64,175.64,0,0,0,225.05,0,0,0,0,0,1,.07,0L416,454.59a.06.06,0,0,0,.08,0L440,432ZM272.07,288h-112A0,0,0,0,1,160,288v-31.9a0,0,0,0,1,.05-.05h80a0,0,0,0,0,0-.05V144h32Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
