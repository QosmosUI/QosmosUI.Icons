// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons.Default;

public class CiMicrochip : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 24 24";

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
		builder.OpenElement(13, "g");
		builder.AddAttribute(14, "id", "Microchip");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M13,14.5H11A1.5,1.5,0,0,1,9.5,13V11A1.5,1.5,0,0,1,11,9.5h2A1.5,1.5,0,0,1,14.5,11v2A1.5,1.5,0,0,1,13,14.5Zm-2-4a.5.5,0,0,0-.5.5v2a.5.5,0,0,0,.5.5h2a.5.5,0,0,0,.5-.5V11a.5.5,0,0,0-.5-.5Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M20.435,14.5h-1.93v-5h1.93a.5.5,0,0,0,0-1h-1.93V8a2.507,2.507,0,0,0-2.5-2.5h-.5V3.565a.508.508,0,0,0-.5-.5.5.5,0,0,0-.5.5V5.5h-5V3.565a.508.508,0,0,0-.5-.5.5.5,0,0,0-.5.5V5.5h-.5A2.5,2.5,0,0,0,5.505,8v.5H3.565a.5.5,0,1,0,0,1h1.94v5H3.565a.5.5,0,1,0,0,1h1.94V16a2.5,2.5,0,0,0,2.5,2.5h.5v1.94a.5.5,0,0,0,1,0V18.5h5v1.94a.5.5,0,0,0,1,0V18.5h.5a2.507,2.507,0,0,0,2.5-2.5v-.5h1.93a.5.5,0,0,0,0-1ZM17.505,16a1.5,1.5,0,0,1-1.5,1.5h-8a1.5,1.5,0,0,1-1.5-1.5V8a1.5,1.5,0,0,1,1.5-1.5h8a1.511,1.511,0,0,1,1.5,1.5Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
