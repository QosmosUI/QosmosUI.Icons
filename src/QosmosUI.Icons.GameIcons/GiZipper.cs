// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons;

public class GiZipper : ComponentBase
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
    public string ViewBox { get; set; } = "0 0 512 512";

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
		builder.AddAttribute(14, "d", "M107.023 17.25L92.71 45.738l16.086 8.08 14.312-28.486zm328.497 4.557l-16.688 6.748 11.95 29.556 16.687-6.746zm-289.79 12.6l-15.335 27.948 15.779 8.66 15.338-27.949zm255.032 1.67l-16.084 8.081 14.312 28.487 16.084-8.08zm-34.914 17.9l-15.032 9.9 17.534 26.625 15.033-9.9zM178.754 55.77l-18.275 26.122 14.748 10.318 18.275-26.121zm155.29 18.243L319.86 85.092l19.623 25.127 14.186-11.08zm-124.47 5.42l-21.847 23.216 13.107 12.336 21.85-23.215zm96.342 18.888l-12.066 13.356 23.656 21.373 12.066-13.356zm-68.059 10.137l-25.48 19.158 10.816 14.387 25.483-19.158zm41.184 21.424l-8.129 16.06 28.445 14.397 8.13-16.059zM256 165c-16.4 0-34.344 10.07-57.637 33.363-2.94 2.94-3.524 4.645-3.629 6.416-.104 1.772.528 4.498 2.983 8.59 4.516 7.526 15.2 18.68 29.283 32.826V199h58v47.195c14.083-14.146 24.767-25.3 29.283-32.826 2.455-4.092 3.087-6.818 2.983-8.59-.105-1.771-.69-3.476-3.63-6.416C290.345 175.07 272.4 165 256 165zm-11 52v86.275c1.705 12.707 7.374 15.725 11 15.725 3.626 0 9.295-3.018 11-15.725V217zm-18 75.738l-25.924 155.547c.089 1.188 1.12 4.786 3.912 8.973 2.915 4.372 7.378 9.332 12.774 13.828C228.552 480.078 243 487 256 487s27.447-6.922 38.238-15.914c5.396-4.496 9.859-9.456 12.774-13.828 2.791-4.187 3.823-7.785 3.912-8.973L285 292.748c1.957 20.065-12.043 43.674-29 44.252-18.338-.45-29-22.772-29-44.262zM256 412c17.673 0 32 10.745 32 24s-14.327 24-32 24c-17.673 0-32-10.745-32-24s14.327-24 32-24z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
