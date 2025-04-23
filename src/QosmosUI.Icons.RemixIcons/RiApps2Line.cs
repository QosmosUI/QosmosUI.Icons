// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.RemixIcons;

public class RiApps2Line : ComponentBase
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
		builder.OpenElement(13, "path");
		builder.AddAttribute(14, "d", "M7 11.5C4.51472 11.5 2.5 9.48528 2.5 7C2.5 4.51472 4.51472 2.5 7 2.5C9.48528 2.5 11.5 4.51472 11.5 7C11.5 9.48528 9.48528 11.5 7 11.5ZM7 21.5C4.51472 21.5 2.5 19.4853 2.5 17C2.5 14.5147 4.51472 12.5 7 12.5C9.48528 12.5 11.5 14.5147 11.5 17C11.5 19.4853 9.48528 21.5 7 21.5ZM17 11.5C14.5147 11.5 12.5 9.48528 12.5 7C12.5 4.51472 14.5147 2.5 17 2.5C19.4853 2.5 21.5 4.51472 21.5 7C21.5 9.48528 19.4853 11.5 17 11.5ZM17 21.5C14.5147 21.5 12.5 19.4853 12.5 17C12.5 14.5147 14.5147 12.5 17 12.5C19.4853 12.5 21.5 14.5147 21.5 17C21.5 19.4853 19.4853 21.5 17 21.5ZM7 9.5C8.38071 9.5 9.5 8.38071 9.5 7C9.5 5.61929 8.38071 4.5 7 4.5C5.61929 4.5 4.5 5.61929 4.5 7C4.5 8.38071 5.61929 9.5 7 9.5ZM7 19.5C8.38071 19.5 9.5 18.3807 9.5 17C9.5 15.6193 8.38071 14.5 7 14.5C5.61929 14.5 4.5 15.6193 4.5 17C4.5 18.3807 5.61929 19.5 7 19.5ZM17 9.5C18.3807 9.5 19.5 8.38071 19.5 7C19.5 5.61929 18.3807 4.5 17 4.5C15.6193 4.5 14.5 5.61929 14.5 7C14.5 8.38071 15.6193 9.5 17 9.5ZM17 19.5C18.3807 19.5 19.5 18.3807 19.5 17C19.5 15.6193 18.3807 14.5 17 14.5C15.6193 14.5 14.5 15.6193 14.5 17C14.5 18.3807 15.6193 19.5 17 19.5Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
