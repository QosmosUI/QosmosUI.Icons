// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome;

public class LiaParachuteBoxSolid : ComponentBase
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
		builder.AddAttribute(14, "d", "M 28 16 C 28 9.382813 22.617188 4 16 4 C 9.382813 4 4 9.382813 4 16 L 4 16.453125 L 12 23.453125 L 12 28 L 20 28 L 20 23.453125 L 28 16.453125 Z M 16 6.363281 C 16.867188 7.304688 18.421875 9.535156 18.871094 13.65625 C 18.148438 13.28125 17.207031 13 16 13 C 14.792969 13 13.851563 13.28125 13.128906 13.65625 C 13.578125 9.53125 15.136719 7.300781 16 6.363281 Z M 11.085938 16.398438 L 13.484375 22 L 13.375 22 L 6.335938 15.839844 C 6.71875 15.449219 7.390625 15 8.5 15 C 10.402344 15 11.058594 16.351563 11.085938 16.398438 Z M 15.660156 22 L 13.140625 16.125 C 13.523438 15.691406 14.378906 15 16 15 C 17.625 15 18.484375 15.695313 18.859375 16.121094 L 16.339844 22 Z M 18.515625 22 L 20.914063 16.398438 C 20.925781 16.382813 21.554688 15 23.5 15 C 24.601563 15 25.273438 15.453125 25.660156 15.84375 L 18.625 22 Z M 25.660156 13.445313 C 25.078125 13.179688 24.367188 13 23.5 13 C 22.390625 13 21.535156 13.292969 20.878906 13.683594 C 20.535156 10.207031 19.46875 7.824219 18.476563 6.320313 C 21.976563 7.21875 24.738281 9.957031 25.660156 13.445313 Z M 13.519531 6.324219 C 12.53125 7.824219 11.464844 10.207031 11.121094 13.683594 C 10.464844 13.292969 9.609375 13 8.5 13 C 7.632813 13 6.921875 13.179688 6.339844 13.445313 C 7.261719 9.957031 10.023438 7.21875 13.519531 6.324219 Z M 18 26 L 14 26 L 14 24 L 18 24 Z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
