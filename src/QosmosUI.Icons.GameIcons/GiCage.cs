// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiCage : ComponentBase
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
		builder.AddAttribute(14, "d", "M119 75v64H55v346h402V139h-64V75H128zm18 18h46v46h-46zm64 0h46v46h-46zm64 0h46v46h-46zm64 0h46v46h-46zM73 157h46v18H73zm64 0h46v18h-46zm64 0h46v18h-46zm64 0h46v18h-46zm64 0h46v18h-46zm64 0h46v18h-46zM73 193h46v46H73zm64 0h46v46h-46zm64 0h46v46h-46zm64 0h46v46h-46zm64 0h46v46h-46zm64 0h46v46h-46zM73 257h46v46H73zm64 0h46v46h-46zm64 0h46v46h-46zm70.508 0h96.984l-26.287 46h20.73L375 281.889v156.22L362.937 417h-20.732l26.287 50h-96.984l26.287-50h-20.733L265 438.11V281.888L277.064 303h20.73zM393 257h46v46h-46zM73 321h46v46H73zm64 0h46v46h-46zm64 0h46v46h-46zm88 0v78h62v-78zm104 0h46v46h-46zm-73 10.043c7.732 0 14 6.268 14 14a14 14 0 0 1-5.19 10.87l5.19 31.13h-28l5.19-31.135a14 14 0 0 1-5.19-10.865c0-7.732 6.268-14 14-14zM73 385h46v46H73zm64 0h46v46h-46zm64 0h46v46h-46zm192 0h46v46h-46zM73 449h46v18H73zm64 0h46v18h-46zm64 0h46v18h-46zm192 0h46v18h-46z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
