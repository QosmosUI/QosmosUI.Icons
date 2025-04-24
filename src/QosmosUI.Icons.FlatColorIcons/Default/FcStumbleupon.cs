// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.FlatColorIcons.Default;

public class FcStumbleupon : ComponentBase
{
    [Parameter]
    public string Title { get; set; } = string.Empty;

    [Parameter]
    public string Size { get; set; } = "48px";

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
    public string ViewBox { get; set; } = "0 0 48 48";

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
		builder.AddAttribute(14, "fill", "#E64A19");
		builder.AddAttribute(15, "d", "M24.001,5c-10.494,0-19,8.506-19,19c0,10.493,8.506,19,19,19c10.493,0,19-8.507,19-19	C43.001,13.506,34.494,5,24.001,5z");
		builder.CloseElement();
		builder.OpenElement(16, "g");
		builder.OpenElement(17, "path");
		builder.AddAttribute(18, "fill", "#FFFFFF");
		builder.AddAttribute(19, "d", "M24.001,19C23.998,19,24.004,19,24.001,19c-0.062-0.004-1,0-1,1v7.876C22.916,29.888,21.504,33,17.959,33		c-3.607,0-4.958-3.065-4.958-4.958V24h4v4c0.038,0.709,0.629,1,1,1c0.665,0,0.972-0.361,1-1v-8.124c0-2.01,1.332-5,5-5		c0.045,0,0.086,0.006,0.131,0.007c0,0,4.869-0.009,4.869,5.117c0,1.104-0.896,1.876-2,1.876s-2-0.771-2-1.876		C25.001,19.124,24.041,19.003,24.001,19z M35.001,27.876c0,2.01-1.331,5.124-5,5.124s-5-3.114-5-5.124v-3.439		c0.614,0.272,1.285,0.439,2,0.439c0.712,0,1.386-0.154,2-0.424V28c0.038,1,0.663,1,1,1c0.247,0,1,0,1-1v-4h4V27.876z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
