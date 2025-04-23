// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaFeatherSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 21.5 4 C 19.698 4 18.020875 4.7254844 16.796875 6.0214844 L 8.6367188 14.175781 C 6.9367187 15.874781 6 18.134063 6 20.539062 L 6 22 L 8.0273438 19.972656 C 8.1593437 18.316656 8.8637813 16.776844 10.050781 15.589844 L 18.230469 7.4140625 C 19.092469 6.5010625 20.254 6 21.5 6 C 23.981 6 26 8.019 26 10.5 C 26 11.746 25.498453 12.906062 24.564453 13.789062 L 22.533203 15.822266 L 19 17 L 21.355469 17 L 17.537109 20.820312 L 14 22 L 16.353516 22 C 15.037878 23.287947 13.305421 24 11.460938 24 L 9.4140625 24 L 18.707031 14.707031 L 17.292969 13.292969 L 4 26.585938 L 5.4140625 28 L 7.4140625 26 L 11.460938 26 C 13.864937 26 16.125219 25.064281 17.824219 23.363281 L 25.957031 15.222656 C 27.275031 13.978656 28 12.302 28 10.5 C 28 6.916 25.084 4 21.5 4 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
