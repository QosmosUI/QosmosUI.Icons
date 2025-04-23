// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.CircumIcons;

public class CiVolume : ComponentBase
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
		builder.AddAttribute(14, "id", "Volume");
		builder.OpenElement(15, "path");
		builder.AddAttribute(16, "d", "M17.849,20.934a1.555,1.555,0,0,1-.781-.212l-4.16-2.4a3.769,3.769,0,0,0-1.877-.5H7.214a2.631,2.631,0,0,1-2.628-2.627V8.809A2.631,2.631,0,0,1,7.214,6.182h3.817a3.747,3.747,0,0,0,1.877-.5l4.16-2.4a1.564,1.564,0,0,1,2.346,1.354V19.369a1.57,1.57,0,0,1-1.565,1.565ZM7.214,7.182A1.63,1.63,0,0,0,5.586,8.809v6.382a1.629,1.629,0,0,0,1.628,1.627h3.817a4.756,4.756,0,0,1,2.377.637l4.16,2.4a.543.543,0,0,0,.563,0,.553.553,0,0,0,.283-.487V4.632a.565.565,0,0,0-.846-.489l-4.16,2.4a4.753,4.753,0,0,1-2.377.637Z");
		builder.CloseElement();
		builder.CloseElement();
		builder.CloseElement();
    }
}
