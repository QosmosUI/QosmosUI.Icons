// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaPillsSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 8.5 5 C 5.467 5 3 7.468 3 10.5 L 3 21.5 C 3 24.532 5.467 27 8.5 27 C 11.533 27 14 24.532 14 21.5 L 14 10.5 C 14 7.468 11.533 5 8.5 5 z M 8.5 7 C 10.43 7 12 8.57 12 10.5 L 12 15 L 5 15 L 5 10.5 C 5 8.57 6.57 7 8.5 7 z M 22.5 14 C 18.916 14 16 16.916 16 20.5 C 16 24.084 18.916 27 22.5 27 C 26.084 27 29 24.084 29 20.5 C 29 16.916 26.084 14 22.5 14 z M 22.5 16 C 24.981 16 27 18.019 27 20.5 C 27 21.378623 26.738056 22.193134 26.300781 22.886719 L 20.113281 16.699219 C 20.806866 16.261944 21.621377 16 22.5 16 z M 5 17 L 12 17 L 12 21.5 C 12 23.43 10.43 25 8.5 25 C 6.57 25 5 23.43 5 21.5 L 5 17 z M 18.699219 18.113281 L 24.886719 24.300781 C 24.193134 24.738056 23.378623 25 22.5 25 C 20.019 25 18 22.981 18 20.5 C 18 19.621377 18.261944 18.806866 18.699219 18.113281 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
