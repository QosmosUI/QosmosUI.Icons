// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaUnlinkSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 21.75 4 C 20.148438 4 18.53125 4.625 17.3125 5.84375 L 15.84375 7.3125 C 14.828125 8.328125 14.226563 9.617188 14.0625 10.9375 L 16.0625 11.1875 C 16.175781 10.28125 16.558594 9.410156 17.25 8.71875 L 18.71875 7.25 C 20.390625 5.578125 23.078125 5.578125 24.75 7.25 C 26.421875 8.921875 26.421875 11.609375 24.75 13.28125 L 23.28125 14.75 L 23.25 14.75 C 22.558594 15.445313 21.714844 15.828125 20.8125 15.9375 L 21.0625 17.9375 C 22.382813 17.773438 23.671875 17.171875 24.6875 16.15625 L 26.15625 14.6875 C 28.589844 12.253906 28.589844 8.277344 26.15625 5.84375 C 24.9375 4.625 23.351563 4 21.75 4 Z M 7.71875 6.28125 L 6.28125 7.71875 L 10.28125 11.71875 L 11.71875 10.28125 Z M 10.9375 14.0625 C 9.617188 14.226563 8.328125 14.828125 7.3125 15.84375 L 5.84375 17.3125 C 3.410156 19.746094 3.410156 23.722656 5.84375 26.15625 C 8.277344 28.589844 12.253906 28.589844 14.6875 26.15625 L 16.15625 24.6875 C 17.171875 23.671875 17.773438 22.382813 17.9375 21.0625 L 15.9375 20.8125 C 15.824219 21.71875 15.441406 22.589844 14.75 23.28125 L 13.28125 24.75 C 11.609375 26.421875 8.921875 26.421875 7.25 24.75 C 5.578125 23.078125 5.578125 20.390625 7.25 18.71875 L 8.71875 17.25 L 8.75 17.25 C 9.441406 16.554688 10.285156 16.171875 11.1875 16.0625 Z M 21.71875 20.28125 L 20.28125 21.71875 L 24.28125 25.71875 L 25.71875 24.28125 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
