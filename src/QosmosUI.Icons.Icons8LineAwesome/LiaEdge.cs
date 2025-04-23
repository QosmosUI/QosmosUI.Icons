// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaEdge : ComponentBase
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
		builder.AddAttribute(14, "d", "M 9.960938 10.828125 C 7.34375 12.457031 5.847656 14.769531 5.847656 14.769531 C 5.847656 14.769531 6.234375 9.917969 9.960938 7.074219 C 11.441406 5.945313 13.46875 5 16.191406 5 C 17.214844 5 19.359375 5.179688 21.292969 6.371094 C 23.226563 7.5625 24.007813 8.558594 24.878906 10.023438 C 25.253906 10.652344 25.5625 11.464844 25.753906 12.246094 C 26.109375 13.710938 26.152344 15.460938 26.152344 15.460938 L 26.152344 17.769531 L 12.335938 17.769531 C 12.335938 17.769531 12 22.410156 18.355469 22.410156 C 20.5625 22.410156 21.339844 22.0625 22.066406 21.847656 C 23.203125 21.511719 24.300781 20.761719 24.300781 20.761719 L 24.304688 25.398438 C 24.304688 25.398438 21.703125 27 17.773438 27 C 16.667969 27 15.503906 26.90625 14.378906 26.542969 C 13.394531 26.222656 11.339844 25.363281 9.960938 23.347656 C 9.472656 22.636719 8.945313 21.6875 8.683594 20.761719 C 8.398438 19.757813 8.402344 18.785156 8.402344 18.246094 C 8.402344 16.242188 9.089844 14.328125 10.277344 12.941406 C 11.816406 11.148438 13.765625 10.359375 13.765625 10.359375 C 13.765625 10.359375 13.132813 11.097656 12.742188 12.019531 C 12.351563 12.941406 12.242188 13.867188 12.242188 13.867188 L 20.046875 13.867188 C 20.046875 13.867188 20.503906 9.203125 15.632813 9.203125 C 13.796875 9.203125 11.542969 9.84375 9.960938 10.828125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
