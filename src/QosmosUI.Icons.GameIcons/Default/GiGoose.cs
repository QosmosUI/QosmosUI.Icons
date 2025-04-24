// Copyright (c) QosmosUI 2025.
// QosmosUI licenses this file to you under the MIT license.
// See the license here https://github.com/QosmosUI/QosmosUI/blob/main/LICENSE.

using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;

namespace QosmosUI.Icons.GameIcons.Default;

public class GiGoose : ComponentBase
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
		builder.AddAttribute(14, "d", "M370.019 18.023c-2.843-.035-5.859.197-9.075.73-81.664 13.54-38.657 142.295-36.095 217.397-84.163-16.327-168.007 121.048-289.118 152.787 58.086 52.473 206.05 89.6 331.739 11.85 39.804-24.622 45.26-92.014 34.343-165.049-6.703-44.845-71.755-133.176-10.269-141.266l.611-.504c12.884-10.608 16.606-23.842 22.522-37.699l1.699-3.976c-11.688-16.016-23.17-33.986-46.357-34.27zm5.08 19.625a9 9 0 0 1 9 9 9 9 0 0 1-9 9 9 9 0 0 1-9-9 9 9 0 0 1 9-9zm52.703 34.172c-3.28 8.167-7.411 17.45-14.612 26.293 21.035 7.63 41.929 3.078 63.079-.863-15.515-9.272-32.003-18.195-48.467-25.43zm-89.608 181.053c19.109 25.924 21.374 53.965 11.637 78.183-9.737 24.219-30.345 44.797-55.67 60.49-50.65 31.389-121.288 44.45-170.553 17.11l8.735-15.738c40.364 22.4 106.342 11.833 152.338-16.67 22.997-14.252 40.72-32.684 48.449-51.906 7.729-19.223 6.596-39.053-9.426-60.79l14.49-10.68zM273.28 456.322a332.68 332.68 0 0 1-19.095 3.232l-3.508 16.426h-13.084l3.508-14.842a400.208 400.208 0 0 1-18.852 1.506l-7.408 31.336h95.79v-18h-41.548l4.197-19.658z");
		builder.CloseElement();
		builder.CloseElement();
    }
}
