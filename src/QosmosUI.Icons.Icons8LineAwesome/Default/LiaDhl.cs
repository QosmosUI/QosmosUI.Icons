// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.Icons8LineAwesome.Default;

public class LiaDhl : ComponentBase
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
		builder.AddAttribute(14, "d", "M 5.6308594 13 L 4.609375 14.390625 L 10.179688 14.390625 C 10.459688 14.390625 10.454453 14.500547 10.314453 14.685547 C 10.174453 14.875547 9.9407813 15.204531 9.8007812 15.394531 C 9.7307812 15.494531 9.5942969 15.669922 10.029297 15.669922 L 12.310547 15.669922 C 12.310547 15.669922 12.674375 15.17 12.984375 14.75 C 13.404375 14.18 13.020391 13 11.525391 13 L 5.6308594 13 z M 15.234375 13 L 13.269531 15.669922 L 20.449219 15.669922 L 22.414062 13 L 19.480469 13 L 18.355469 14.529297 L 17.044922 14.529297 L 18.169922 13 L 15.234375 13 z M 23.375 13 L 21.410156 15.669922 L 24.519531 15.669922 L 26.484375 13 L 23.375 13 z M 6.2441406 14.740234 L 4.1894531 17.529297 L 9.1953125 17.529297 C 10.850312 17.529297 11.769687 16.405625 12.054688 16.015625 L 8.6445312 16.015625 C 8.2095312 16.015625 8.3440625 15.835234 8.4140625 15.740234 C 8.5540625 15.550234 8.7955469 15.220156 8.9355469 15.035156 C 9.0755469 14.850156 9.0749219 14.740234 8.7949219 14.740234 L 6.2441406 14.740234 z M 0 16.015625 L 0 16.335938 L 4.5292969 16.335938 L 4.765625 16.015625 L 0 16.015625 z M 13.015625 16.015625 L 11.900391 17.525391 L 14.835938 17.525391 L 15.949219 16.015625 L 13.015625 16.015625 z M 17.265625 16.015625 C 17.260625 16.015625 16.150391 17.525391 16.150391 17.525391 L 19.085938 17.525391 L 20.199219 16.015625 L 17.265625 16.015625 z M 21.154297 16.015625 C 21.154297 16.015625 20.940937 16.309219 20.835938 16.449219 C 20.465937 16.949219 20.789141 17.529297 21.994141 17.529297 L 26.710938 17.529297 L 27.824219 16.015625 L 21.154297 16.015625 z M 28.365234 16.015625 L 28.130859 16.335938 L 32 16.335938 L 32 16.015625 L 28.365234 16.015625 z M 0 16.609375 L 0 16.929688 L 4.0898438 16.929688 L 4.3242188 16.609375 L 0 16.609375 z M 27.925781 16.609375 L 27.689453 16.929688 L 32 16.929688 L 32 16.609375 L 27.925781 16.609375 z M 0 17.205078 L 0 17.525391 L 3.6542969 17.525391 L 3.890625 17.205078 L 0 17.205078 z M 27.484375 17.210938 L 27.25 17.529297 L 32 17.529297 L 32 17.210938 L 27.484375 17.210938 z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
