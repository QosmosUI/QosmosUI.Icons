// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiLemon : ComponentBase
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
		builder.AddAttribute(14, "id", "Lemon");
		builder.OpenElement(15, "g");
		builder.OpenElement(16, "path");
		builder.AddAttribute(17, "d", "M6,20.924a2.172,2.172,0,0,1-1.545-.642l-.734-.733a2.207,2.207,0,0,1-.16-2.947,1.18,1.18,0,0,0,.272-1.117A9.105,9.105,0,0,1,6.205,6.208a9.1,9.1,0,0,1,9.277-2.371,1.149,1.149,0,0,0,1.062-.229l.055-.044a2.205,2.205,0,0,1,2.946.161l.734.733a2.207,2.207,0,0,1,.16,2.947,1.179,1.179,0,0,0-.272,1.116A9.11,9.11,0,0,1,17.8,17.8,9.109,9.109,0,0,1,8.518,20.17a1.14,1.14,0,0,0-1.062.229A2.324,2.324,0,0,1,6,20.924ZM12.812,4.4a8.427,8.427,0,0,0-5.9,2.519,8.1,8.1,0,0,0-2.133,8.246,2.149,2.149,0,0,1-.395,2.014,1.227,1.227,0,0,0,.044,1.667l.734.733a1.209,1.209,0,0,0,1.613.088,2.175,2.175,0,0,1,2.067-.438,8.1,8.1,0,0,0,8.246-2.133,8.1,8.1,0,0,0,2.133-8.246,2.144,2.144,0,0,1,.395-2.013,1.229,1.229,0,0,0-.044-1.668l-.734-.733a1.206,1.206,0,0,0-1.612-.089l-.052.042a2.148,2.148,0,0,1-2.016.4A7.213,7.213,0,0,0,12.812,4.4Z");
		builder.CloseElement();
		builder.OpenElement(18, "path");
		builder.AddAttribute(19, "d", "M6.457,12.286a.523.523,0,0,1-.178-.032.5.5,0,0,1-.29-.646,9.841,9.841,0,0,1,5.338-5.5.5.5,0,1,1,.386.921,8.845,8.845,0,0,0-4.789,4.939A.5.5,0,0,1,6.457,12.286Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
