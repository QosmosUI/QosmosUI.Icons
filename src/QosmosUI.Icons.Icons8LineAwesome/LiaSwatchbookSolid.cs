// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaSwatchbookSolid : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 32 32";

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
		builder.AddAttribute(14, "d", "M 5 5 L 5 23 C 5 25.206 6.794 27 9 27 C 11.206 27 13 25.206 13 23 L 13 5 L 5 5 z M 7 7 L 11 7 L 11 11 L 7 11 L 7 7 z M 18.900391 7.4433594 L 14.501953 11.84375 L 14.501953 14.669922 L 18.898438 10.271484 L 21.728516 13.099609 L 14.5 20.328125 L 14.5 23 C 14.5 23.056 14.493188 23.108062 14.492188 23.164062 L 24.556641 13.101562 L 18.900391 7.4433594 z M 7 13 L 11 13 L 11 17 L 7 17 L 7 13 z M 7 19 L 11 19 L 11 23 C 11 24.103 10.103 25 9 25 C 7.897 25 7 24.103 7 23 L 7 19 z M 20.777344 19 L 18.777344 21 L 25 21 L 25 25 L 14.777344 25 L 12.888672 26.888672 C 12.846672 26.930672 12.796906 26.96 12.753906 27 L 27 27 L 27 19 L 20.777344 19 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
