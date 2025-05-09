// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaVine : ComponentBase
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
		builder.AddAttribute(14, "d", "M 25.644531 15.9375 C 25.074219 16.066406 24.527344 16.125 24.035156 16.125 C 21.257813 16.125 19.121094 14.1875 19.121094 10.816406 C 19.121094 9.164063 19.761719 8.304688 20.664063 8.304688 C 21.523438 8.304688 22.097656 9.074219 22.097656 10.640625 C 22.097656 11.527344 21.859375 12.503906 21.683594 13.082031 C 21.683594 13.082031 22.535156 14.574219 24.875 14.113281 C 25.371094 13.011719 25.644531 11.585938 25.644531 10.332031 C 25.644531 6.960938 23.925781 5 20.773438 5 C 17.535156 5 15.640625 7.488281 15.640625 10.773438 C 15.640625 14.023438 17.160156 16.816406 19.667969 18.085938 C 18.613281 20.195313 17.273438 22.054688 15.875 23.453125 C 13.335938 20.382813 11.042969 16.289063 10.101563 8.304688 L 6.355469 8.304688 C 8.085938 21.605469 13.242188 25.84375 14.605469 26.65625 C 15.375 27.117188 16.039063 27.097656 16.746094 26.699219 C 17.851563 26.070313 21.175781 22.746094 23.015625 18.855469 C 23.789063 18.851563 24.71875 18.765625 25.644531 18.554688 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
