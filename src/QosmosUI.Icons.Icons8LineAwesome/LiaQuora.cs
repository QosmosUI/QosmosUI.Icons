// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaQuora : ComponentBase
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
		builder.AddAttribute(14, "d", "M 15.492188 4 C 10.201187 4 5 8.2304531 5 14.439453 C 5 21.556453 11.968844 26.19875 18.214844 24.46875 C 19.260844 26.25175 20.638625 28 23.265625 28 C 27.606625 28 28 24 28 23 L 26.445312 23 C 26.365313 23.716 25.877594 24.457031 24.683594 24.457031 C 23.595594 24.457031 22.810641 23.704594 22.056641 22.558594 C 24.402641 20.743594 25.949219 17.9135 25.949219 14.4375 C 25.954219 8.2025 20.894188 4 15.492188 4 z M 15.492188 6 C 19.536188 6 21.261719 8.9094531 21.261719 14.439453 C 21.266719 16.657453 20.973047 18.450484 20.373047 19.771484 C 19.338047 18.221484 18.054578 17.001953 15.517578 17.001953 C 13.898578 17.001953 12.792719 17.473344 12.011719 18.152344 L 12.658203 19.443359 C 12.987203 19.284359 13.193688 19.289062 13.554688 19.289062 C 15.438688 19.289062 16.404562 20.924969 17.226562 22.542969 C 16.695563 22.701969 16.126234 22.765625 15.490234 22.765625 C 11.510234 22.765625 9.7851563 19.952219 9.7851562 14.449219 C 9.7861563 8.9082188 11.512187 6 15.492188 6 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
